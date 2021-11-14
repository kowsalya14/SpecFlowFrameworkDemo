Feature: Login
	Login to LeafTaps Website

@Smoke
Scenario: Perfrom Login in LeafTaps Application
	#steps
	Given I launch the application 
	And I enter the Username and Pasword		
	Usename | Password
	abc | new
	And I click login button
	Then I should see CRM SFA link
	And I Tap on CRM Link 
	Then I should see Page Title as "My Home | opentaps CRM"
	And I should click Home link