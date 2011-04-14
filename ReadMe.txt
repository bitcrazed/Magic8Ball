Author: Richard Turner [rich@bitcrazed.com]
Release 1.0
Date: April 13th 2011

This project demonstrates how to use Windows Communication Foundation (WCF) to
host a simple service from within a console application and consume that 
service from a simple WPF app. 

The simple Magic8Ball replies to questions with a random response from a 
pre-defined list of possible responses.

The service is hosted by a simple console application to illustrate that apps
can host services too! This service is exposed simultaneously using XML/HTTP 
and BinaryXML/TCP endpoints. The service will also respond to HTTP-GET's with
a service description page - point your browser at the service's HTTP 
endpoint for more details.

The client app is a simple WPF app that lets you ask questions of the 
Magic8Ball service and displays the answer provided.

This project also shows how to configure services & clients using app.config,
significantly reducing the quantity of code required to hook-up a client to a 
service, whilst greatly increasing post-deployment flexibility. Read 
Magic8BallApp's app.config for more details.

I have used variations of this app for many years to explain and demonstrate 
key WCF features. I hope you find it useful.

Play. Tweak. Modify. Enjoy!