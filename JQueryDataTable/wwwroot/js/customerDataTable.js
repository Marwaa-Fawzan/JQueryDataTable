$(document).ready(function () {
    $('#Customers').dataTable({
        "serverside": true,
        "filter": true,
        "ajax": {
            "url": "/api/customers",
            "type": "POST",
            "datatype" : "json"
        },
        "columnDefs": [{
            "targets": [0],
            "visible": false,
            "searchable": false
        }],
        "columns": [
            { "data": "id", "name": "Id", "autowidth": true },
            { "data": "firstName", "FirstName": "Id", "autowidth": true },
            { "data": "lastName", "LastName": "Id", "autowidth": true },
            { "data": "contact", "Contact": "Id", "autowidth": true },
            { "data": "email", "name": "Email", "autowidth": true },
            { "data": "dateOfBirth", "DateOfBirth": "Id", "autowidth": true },
            { "render": function (data, type, row) { return '<a href="#" class="btn btn-danger" onclick=DeleteCustomer("' + row.id + '") > Delete </a>' },
                "orderTable": false
            }
        ]
    });
});