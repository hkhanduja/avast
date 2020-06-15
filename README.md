There are 3 projects in total 
## Avast.PrimeNumbers.Web
This is the start up web project where you can enter the value of N which is input from user for count of grid
As per requirement it is incremented by 1 to display N+1 * N+1 grid(multiplication table)
It is assumed that first row and first column of grid would display the list of N prime numbers and rest is just multiplication table
## Avast.Utilities

* IPrimeNumbers.cs and Primenumbers.cs are the interface and its implementation for better testabilty and mocking (if required)
  Logic to generate the list of n prime number is kept very simple and only optimised to a level of square root of N

## Avast.Utilities.Test
* This is core mstest where some basic tests are added in the form of 3a's (Arrange,Act and assert)

