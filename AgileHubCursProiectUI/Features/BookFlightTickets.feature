Feature: BookFlightTickets
	In order to book some flight tickets
	As an unregistered user
	I want to see the price tickets and then to acces my account if I have one

@FindTicketsPrice
Scenario: FindTicketsPrice
	Given I go to the 'https://wizzair.com/ro-ro#/' website and choose the tickets data
	When I select the flights
	Then I can see the total price