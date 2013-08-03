##Windows Invoice

The respository contains a invoice application in the following forms:

1. Windows Store
* Windows Phone 8
* Web Site

The application will allow you to do the following.

1.Manage Customers (List, Add, Delete, Edit)
* Manage Invoices (List, Add, Delete(soft), Edit)

The application won't cover authentication as it is a test application to illustrate code reuse and what it 
entails to code up the different projects.

###Problem Domain
The application needs to list all the invoices.  The list should contain the following information about the invoice:

1. Who was invoiced.
2. When were they invoiced
3. Amount Invoiced

The Application is going to structured in the following way.  The client apps are going to talk to a web api.  The api is
going to be built using asp.net mvc web api.  We are going to be using the .net 4.5 framework.


