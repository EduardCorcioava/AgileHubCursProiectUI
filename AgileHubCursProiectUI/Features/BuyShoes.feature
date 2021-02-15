Feature: BuyShoes
	In order to buy something
	As a customer
	I want to be able to see the cart with my product and the return policy

@AddShoesToCart
Scenario: AddShoesToCart
	Given I go to the 'https://adidas.co.uk' website and select men shop
	 When I choose the shoes
	 Then I can see them in the cart

@SeeReturnPolicy
Scenario: SeeReturnPolicy
	Given I go to the 'https://adidas.co.uk' website and select men shop
	 When I select exchanges%return option 
	  And I choose the return policy
	 Then I can see how can I return my product