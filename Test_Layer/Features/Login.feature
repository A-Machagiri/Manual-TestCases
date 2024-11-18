Feature: Login to SauceDemo

Scenario: Successful Login
    Given I navigate to "https://www.saucedemo.com/"
    When I enter valid username "standard_user"
    And I enter valid password "secret_sauce"
    And I click on the login button