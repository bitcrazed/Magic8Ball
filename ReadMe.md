#Magic8Ball WCF Demo App and Service

This project demonstrates how to use Windows Communication Foundation (WCF) to host a simple service from within a console application and consume that service from a simple WPF app. 

The simple Magic8Ball replies to questions with a random response from a pre-defined list of possible responses.

The service is hosted by a simple console application to illustrate that apps can host services too! This service is exposed simultaneously using XML/HTTP and BinaryXML/TCP endpoints. The service will also respond to HTTP-GET's with a service description page - point your browser at the service's HTTP endpoint for more details.

The client app is a simple WPF app that lets you ask questions of the Magic8Ball service and displays the answer provided.

This project also shows how to configure services & clients using app.config, significantly reducing the quantity of code required to hook-up a client to a service, whilst greatly increasing post-deployment flexibility. Read Magic8BallApp's app.config for more details.

I have used variations of this app for many years to explain and demonstrate key WCF features. I hope you find it useful.

Play. Tweak. Modify. Enjoy!

##Release History
###Release 1.1 (1st December 2011)
- Exposed service via new webHttpBinding to support REST & JSON clients.
- Added support for cross-domain requests to support test HTML page.
- Added test HTML page to exercise new webHttpBinding endpoint.
- Several minor improvements to user experience in the client app and server host.
- Removed unnecessary references and using statements.

###Release 1.0 (13th April 2011)
- Initial release ported to .NET 4.0 and cleaned up for public consumption.

###Copyright:
© 2011, Richard Turner (rich@bitcrazed.com)
