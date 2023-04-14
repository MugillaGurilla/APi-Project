Feature: APIRequestReturnsJSONFormat

An API request returns information formatted as JSON

Background:
	Given that I have initialised a D&D 5E API service 

@Happy
Scenario: If I enter a valid API request the information returned should be formatted as JSON
	Given I make a valid API request
	When I execute the request
	Then the response should be in a Json format


@Sad
Scenario: If I enter an invalid API request the information returned should be formatted as JSON
	Given I make a valid API request
	When I execute the request
	Then the response should be in a Json format

