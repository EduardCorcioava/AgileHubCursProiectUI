Feature: ShoppingOnline
	In order to do some shopping online
	As a logged in user
	I can see the products and my account information

@BuyAsANewUser
Scenario: BuyAsANewUser
	Given I go to an e-commerce website
	And I choose what I want to buy
	When I'm creating an account
		| emailAdress       |  | firstName |  | lastName |  | password   |  | address    |  | city   |  | postcode |  | mobilePhone |  | alias    |
		| marian3@gmail.com |  | marian    |  | vasile   |  | vasile2021 |  | Brasov, 19 |  | Brasov |  | 48950    |  | 0623546789  |  | Iasi, 24 |
	Then my order is processed successfully

@ModifyAccountInformation
Scenario: ModifyAccountInformation
	Given I login with my credentials
		| emailAddress      |  | password   |
		| marian3@gmail.com |  | vasile2021 |
	And I open may personal information page
	When I enter the new information
		| password   |  | newPassword |
		| vasile2021 |  | vasile2022  | 
	Then my new data are saved successfully