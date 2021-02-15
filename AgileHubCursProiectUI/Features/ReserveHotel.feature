Feature: ReserveHotel
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@ReserveHotelAsNewUser
Scenario: ReserveHotelAsNewUser
	Given I go to the travel agency website and choose the travel information
	And I choose the location
	When I book the hotel room
	Then I can see my booking details