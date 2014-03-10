Pocket Contacts
---------------

Main Screen would be a list of contacts
At first the contact list would be empty
Use the longlistselector windows phone control.
The contact should have a name and an email address.

The contacts are gonna be stored in the cloud using the following api

base url: https://api.mongolab.com/api/1

list contacts
-------------
method: GET
request: /databases/sampledatapeople/collections/contacts?apiKey=myAPIKey

add contact
-----------
method: POST
request: /databases/sampledatapeople/collections/contacts?apiKey=myAPIKey
Content-Type: application/json
Body:  {"name" : "Paul", "email" : "paul.allies@gmail.com1" } 

update Contact
---------------
method: PUT
request: /databases/sampledatapeople/collections/contacts?apiKey=myAPIKey&q={"_id":1234}
Content-Type: application/json
Body:  { "$set" : { "email" : "paul.allies@gmail.com1" } }

delete Contact
--------------
method: DELETE
request: databases/sampledatapeople/collections/contacts/4e7315a65e4ce91f885b7dde?apiKey=myAPIKey
Content-Type: application/json



