Feature: SignIn
	In order to use Amazon website
	I need to SignIn
	To enjoy the free site

@mytag
Scenario: SignIn
	Given That i navigate to the website 
	When I click on Hello sign in
	And I enter Email
	And I click continue
	And I enter password "Tolulope1"
	Then Click SignIn