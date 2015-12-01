Feature: QA_Works_Contact_Us_Page
	As an end user
	I want a contact us page
	So that I can find out more about QA Works exciting services

Background: I am on the QA Works HomePage
	Given I am on the QAWorks Staging Site

@ContactUs
Scenario: Valid Submision
	When I navigate to the Contact Us page
	Then I should be able to contact QAWorks with the following information
	| name          | email                | message                                   |
	| j.Bloggs    6 | j.Bloggs@qaworks.com | please contact me I want to find out more |
