Feature: Calculator

A short summary of the feature
As a user
    I want to perform multiplication, subtraction, and division
    So that I can use a calculator for basic arithmetic operations


@mytag

 
Scenario: Multiply two numbers
    Given I have entered 5 into the calculator
    And I have entered 3 into the calculator
    When I press multiply
    Then the result should be 15 

Scenario: Subtract two numbers
    Given I have entered 8 into the calculator
    And I have entered 4 into the calculator
    When I press subtract
    Then the result should be 4 

Scenario: Divide two numbers
    Given I have entered 10 into the calculator
    And I have entered 2 into the calculator
    When I press divide
    Then the result should be 5 