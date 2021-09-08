Feature: Signin
	As a registered user of the sauce demo website
	I want to be able to sign in
	So that I can browse and buy the products

@sad
Scenario: Wrong password
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "sauce"
	When I click submit
	Then I should see an error message "Epic sadface: Username and password do not match any user in this service"

@sad
Scenario: problem user
	Given I am on the signin page
	And I have entered the username "problem_user"
	And I have entered the password "secret_sauce"
	When I click submit
	Then I should be directed to the homepage
	And The correct images is not displayed

@sad
Scenario: problem user
	Given I am on the signin page
	And I have entered the username "locked_out_user"
	And I have entered the password "secret_sauce"
	When I click submit
	Then I should see an error message "Epic sadface: Sorry, this user has been locked out."

@sad
Scenario: Performance glitch user
	Given I am on the signin page
	And I have entered the username "performance_glitch_user"
	And I have entered the password "secret_sauce"
	When I click submit
	Then I should be directed to the homepage
	And The pages take too long to load

@login
Scenario: Invalid email - using SpecFlow assist
	Given I am on the signin page
	And I have the following crednetials
	| Username		| Password |
	| standard_user | nish     |
	When I click submit
	Then I should see an error message "Epic sadface: Username and password do not match any user in this service"

@happy
Scenario: Succesfully logged in
	Given I am on the signin page
	And I have entered the username "standard_user"
	And I have entered the password "secret_sauce"
	When I click submit
	Then I should be directed to the homepage