# UserDetails - ASP.NET Core App with MongoDB

A basic CRUD and search web application using ASP.NET Core MVC and MongoDB.
Written in C#, ASP.NET Core MVC and MongoDB, the application has features to add, update, delete and filter/search User Details. 

## Table of Content

 - [Requirements](#requirements)
 - [Tech Stack](#tech-stack)
 - [Preview Demo](#preview-demo)
 - [Trello Board](#trello-board)
 - [Importing Data in MongoDB](#importing-data-in-mongodb)
 - [Instructions for running the application](#instructions-for-running-the-application)

## Requirements

Design and build a RESTful API that implements the following features:
<ol>
	<li>Save, retrieve, update, and delete user information.</li>
	<li>Search user information using criteria age range AND / OR a list of home states.</li>
</ol>

Bonus points: Support for additional parameters
<ol type="a">
	<li>Home type</li>
	<li>Home zip code</li>
	<li>Number of kids</li>
</ol>
 
## Tech Stack

 - C#, ASP.NET Core MVC
 - MongoDB
 
## Preview Demo

![UserDetails](../master/data/UserDetails.gif)
 
## Trello Board

The following project has been excuted with the help of tracking task in [Trello Board](https://trello.com/b/hsFGT0Aa/).

## Importing Data in MongoDB

Pre-requisite: MongoDB should be installed on the machine where you will be running this app.

Prior running the application, please follow the below step to set up the database:

- Create a database named 'Users'
- Create a collection named 'userDetails' in the newly created database.
- Navigate to data folder and select users.json file.
- Import the users.json in MongoDB collection.

## Instructions for running the application

Below are the step for running the application

- Git clone the repo on your machine.
- Get the data ready in MongoDB as described in the previous section.
- Once, data is set up, open visual studio 2017, build and run the application.

Thank you!
