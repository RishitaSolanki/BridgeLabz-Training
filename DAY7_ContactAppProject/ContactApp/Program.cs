using ContactApp.Model;
using ContactApp.Repository;
using ContactApp.Service;

var builder = WebApplication.CreateBuilder(args);


// ================= SWAGGER =================

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<ContactRepository>();
builder.Services.AddScoped<ContactService>();


var app = builder.Build();


// ================= SWAGGER =================

app.UseSwagger();
app.UseSwaggerUI();


// ================= HOME =================

app.MapGet("/", () =>
{
    return "Contact API Running";
});


// ================= GET ALL CONTACTS =================

app.MapGet("/contacts", (ContactService service) =>
{
    return service.GetContacts();
});


// ================= GET CONTACT BY ID =================

app.MapGet("/contacts/{id}", (int id, ContactService service) =>
{
    var contact = service.GetContactById(id);

    if (contact == null)
    {
        return Results.NotFound("Contact not found");
    }

    return Results.Ok(contact);
});

// ================= GET CONTACT BY PHONE =================

app.MapGet("/contacts/phone/{phone}", 
(string phone, ContactService service) =>
{
    var contact = service.GetContactByPhone(phone);


    if(contact == null)
    {
        return Results.NotFound("Contact not found");
    }


    return Results.Ok(contact);

});


// ================= POST CONTACT =================

app.MapPost("/contacts", (Contact contact, ContactService service) =>
{
    service.AddContact(contact);

    return Results.Created(
        $"/contacts/{contact.Id}",
        contact
    );
});

// ================= UPDATE CONTACT =================

app.MapPut("/contacts/{id}", 
(int id, Contact contact, ContactService service) =>
{

    contact.Id = id;

    var result = service.UpdateContact(contact);


    if(result == false)
    {
        return Results.NotFound("Contact not found");
    }


    return Results.Ok("Contact updated successfully");

});


// ================= DELETE CONTACT =================

app.MapDelete("/contacts/{id}", (int id, ContactService service) =>
{
    service.DeleteContact(id);

    return Results.Ok("Contact deleted successfully");
});


app.Run();