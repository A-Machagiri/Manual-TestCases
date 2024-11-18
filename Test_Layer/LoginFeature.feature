Feature: Login

  Scenario Outline: Valid Login
    Given I navigate to the login page
    When I enter username '<username>' and password '<password>'
    And I click on the login button
    Then I should be redirected to the products page

  Examples:
    | username       | password     |
    | standard_user  | secret_sauce |

  Scenario: Invalid Login with Incorrect Username
    Given I navigate to the login page
    When I enter username 'incorrect_user' and password 'secret_sauce'
    And I click on the login button
    Then an error message should be displayed indicating invalid username

  Scenario: Invalid Login with Incorrect Password
    Given I navigate to the login page
    When I enter username 'standard_user' and password 'wrong_password'
    And I click on the login button
    Then an error message should be displayed indicating incorrect password

  Scenario: Login with Empty Username
    Given I navigate to the login page
    When I leave the username field empty and enter password 'secret_sauce'
    And I click on the login button
    Then an error message should be displayed indicating that username is required

  Scenario: Login with Empty Password
    Given I navigate to the login page
    When I enter username 'standard_user' and leave the password field empty
    And I click on the login button
    Then an error message should be displayed indicating that password is required