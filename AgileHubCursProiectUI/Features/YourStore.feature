Feature: YourStore
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@RegisterAccount
Scenario: RegisterAccount
	Given I go to the store website and I access the registration page
	When filled all the data
	Then I can see that my account was created