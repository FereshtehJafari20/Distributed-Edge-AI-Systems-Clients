# Edge AI Occupancy Monitoring System

This repository contains C# code for a client-server application that simulates occupancy sensors sending occupancy data to a server and requesting aggregated occupancy data. The server stores the data points and provides the aggregated data upon request.
## Objective
The objective of this application is to develop a client-server system where clients represent occupancy sensors. The clients send occupancy data points to the server, and the server aggregates this data to provide the latest occupancy status for each location.

## Data Format
### Occupancy Point Data (Clients to Server): ###

Location Coordinates: A pair [x, y] where x and y are integers ranging from 0 to 99, representing a point coordinate.
Occupancy Value: A binary value where 0 indicates the space at the given coordinates is empty, and 1 indicates it is occupied.

## Implementation Details ##
The server is implemented using TCP/IP sockets in C#. It listens for incoming client connections and handles data communication.
Each client, representing an occupancy sensor, sends occupancy data points to the server and can request aggregated occupancy data.
The server stores received occupancy data points and provides aggregated data upon request.
Data is temporarily stored in memory using a dictionary. No permanent storage or database connection is required for this implementation.
Both client and server hardware are assumed to be powerful enough to run a general-purpose Linux distribution, comparable to the performance of a Raspberry Pi.

## Usage ##
### Client ###
Compile and run the Client project.
The client connects to the server and sends simulated occupancy data.
It can also request aggregated occupancy data from the server.

## Code Structure ##
### Client ###
Program.cs: Main client application responsible for connecting to the server and sending/receiving data.

## Dependencies ##
.NET Core 3.1 or later

## How to Run ##
Clone this repository to your local machine.
Compile and run the Server project.
Compile and run the Client project.

## Contributor ##
Masoumeh (Fereshteh) Jafari-Kaffash
