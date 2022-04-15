Feature: Automationform
As a user on BlueSkyCitadel.com
I want to fill the automation form
So that i can complete the registration

Rule: Every external users should be able to register on the website

@workitem118
Scenario: Valid Automation Testing Form
  Given I Navigate to BlueSky Testing Form
  When I Enter the single line text "One"
  And I Select one in the Select box page
  And I Enter email "tester@yahoo.com"
  And I Enter the password "Tester10"
  And I Select Multi-Select 
  And I Select Radio list
  And I Select Checkbox list
  And I Select United States as my Country
  And I Enter the date "03/26/2022"
  And I Click on the Single Checkbox
  And I Enter the Paragraph Text "Clear Form"
  And I click on the submit button
  Then the messsage "Your form has been successfully submitted" is displayed on the form page



  @workitem118
Scenario: Invalid Automation Testing Form
  Given I Navigate to BlueSky Testing Form
  When I Enter the single line text "One"
  And I Select one in the Select box page
  And I Enter email "tester@yahoo.com"
  And I Select Multi-Select 
  And I Select Radio list
  And I Select Checkbox list
  And I Select United States as my Country
  And I Enter the date "03/26/2022"
  And I Click on the Single Checkbox
  And I Enter the Paragraph Text "Clear Form"
  And I click on the submit button
  Then the Error messsage "Please correct errors before submitting this form" is displayed on the form page