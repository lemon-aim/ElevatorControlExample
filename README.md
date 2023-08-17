# ElevatorControlExample

## Overview 
	This is an example software that provides an http interface for operating an elevator.

## Prerequisites 
	Users will need dotnet version 6.0 

## Running the code 
	The following command runs the application

	dotnet run --project .\ElevatorControlExample\

## Documentation

### Swagger
	Swagger documentation is included.  Use the contents of Swagger.json at https://editor.swagger.io/ to explore the API.

### Endpoints

#### CallElevator
	Used when a user requests an elevator pick them up.
	curl -X 'POST' \
		'http://localhost:8080/api/Elevator/CallElevator?floor=3' \
		-H 'accept: text/plain' \
		-d ''	
#### SelectFloor
	Used when a floor is selected by a user inside an elevator
	curl -X 'POST' \
		'http://localhost:8080/api/Elevator/SelectFloor?floor=4' \
		-H 'accept: text/plain' \
		-d ''

#### SelectedFloors
	Determines which floors are active as selected by SelectFloor endpoint

	curl -X 'GET' \
		'http://localhost:8080/api/Elevator/SelectedFloors' \
		-H 'accept: text/plain'

#### NextFloor
	Displays the next floor the elevator will travel too

	curl -X 'GET' \
		'https://localhost:7272/api/Elevator/NextFloor' \
		-H 'accept: text/plain'


