using ContactApp.Model;
using ContactApp.Repository;
using ContactApp.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// ================= EF CORE =================

builder.Services.AddDbContext<ContactDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));


// ================= DEPENDENCY INJECTION =================

builder.Services.AddScoped<ContactRepository>();
builder.Services.AddScoped<ContactService>();


// ================= SWAGGER =================

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
    var contacts = service.GetContacts();

    return Results.Ok(contacts);
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

    if (contact == null)
    {
        return Results.NotFound("Contact not found");
    }

    return Results.Ok(contact);
});


// ================= POST CONTACT =================

app.MapPost("/contacts", 
    (Contact contact, ContactService service) =>
{
    var newContact = service.AddContact(contact);

    return Results.Created(
        $"/contacts/{newContact.Id}",
        newContact
    );
});


// ================= UPDATE CONTACT =================

app.MapPut("/contacts/{id}", 
    (int id, Contact contact, ContactService service) =>
{
    contact.Id = id;

    var result = service.UpdateContact(contact);

    if (!result)
    {
        return Results.NotFound("Contact not found");
    }

    return Results.Ok("Contact updated successfully");
});


// ================= DELETE CONTACT =================

app.MapDelete("/contacts/{id}", 
    (int id, ContactService service) =>
{
    var result = service.DeleteContact(id);

    if (!result)
    {
        return Results.NotFound("Contact not found");
    }

    return Results.Ok("Contact deleted successfully");
});


app.Run();