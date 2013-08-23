Feature: Calculate
	In order to get discounted price
	As a clerk
	I want to enter the total price	

Scenario: Total price over 100 dollar, get 20% discount
	Given total price as 120 dollar	
	When do caculation
	Then discounted price is 96 dollar

Scenario: Total price between 20 dollar and 100 dollar, get 10% discount
	Given total price as 80 dollar	
	When do caculation
	Then discounted price is 72 dollar

Scenario: Total price less than 20 dollar, get no discount
	Given total price as 10 dollar	
	When do caculation
	Then discounted price is 10 dollar