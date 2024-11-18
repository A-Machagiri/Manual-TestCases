Feature: Login functionality for SauceDemo website

Scenario: Successful login
    Given I navigate to "https://www.saucedemo.com/"
    When I enter valid username "standard_user"
    And I enter valid password "secret_sauce"
    And I click on login button
    Then I should be redirected to the products page

Scenario: Failed login
    Given I navigate to "https://www.saucedemo.com/"
    When I enter invalid username "invalid_user"
    And I enter invalid password "invalid_password"
    And I click on login button
    Then I should see an error message