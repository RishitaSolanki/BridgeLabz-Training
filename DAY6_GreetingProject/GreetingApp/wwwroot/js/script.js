function saveName()
{
    let name = document.getElementById("name").value;


    console.log("Name entered:", name);


    fetch('/Home/SaveName',
    {
        method: 'POST',

        headers:
        {
            'Content-Type': 'application/json'
        },

        body: JSON.stringify(
        {
            Name: name
        })

    })

    .then(response => response.json())

    .then(data =>
    {
        alert(data.message);
    })

    .catch(error =>
    {
        console.log("Error:", error);
    });

}




function submitName()
{

    fetch('/Home/Submit',
    {
        method: 'GET'
    })


    .then(response => response.json())


    .then(data =>
    {
        document.getElementById("result").innerHTML =
        data.message;
    })


    .catch(error =>
    {
        console.log("Error:", error);
    });

}