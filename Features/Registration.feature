Feature: Registration
As a user of Longrichway.com
I want to register on the website
So that I can buy Longrich product

Rule: Every Exterbal Users should be able to Register on the website

@workItem111
Scenario: Valid Registration
	Given I navigate to longrichway.com
	When I click on Register button
	And I enter First name "Tester"
	And I enter Last name "BlueSky"
	And I enter Email Address "tester@yahoo.com"
	And I enter Phone "07412121212"
	And I enter Password "Olu1212"
	And I enter Confirm Password "Pswd1212"
	And I enter Address "19 Oga Deji Street"
	And I enter Town "Lagos"
	And I enter State "Lagos"
	And I click on create Account
	Then the message "Registration successful, Login to your Account" is displayed on the page

Scenario: Invalid Registration
  Given I navigate to longrichway.com
  When I click on Register button
  And I enter First name "Tester"
  And I enter Last name ""
  And I enter Email Address "tester@yahoo.com"
  And I enter Phone "07412121212"
  And I enter Password "Olu1212"
  And I enter Confirm Password "Olu1212"
  And I enter Address "19 Oga Deji Street"
  And I enter Town "Lagos"
  And I enter State "Lagos"
  And I click on create Account
  Then the Error message "The Lastname is Required" is displayed on the page

