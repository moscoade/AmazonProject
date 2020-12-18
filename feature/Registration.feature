Feature: Amazon
	In order for customers to use
	Amazon website

@mytag
Scenario: Registration
	Given That i navigate to the website 
	When I click on Hello sign in
	And I click on Create your Amazon account
	And I enter my Name
	And I enter Email 
	And I enter password "Tolulope1"
	And I re-enter password "Tolulope1"
	Then I click on Create your Amazon account