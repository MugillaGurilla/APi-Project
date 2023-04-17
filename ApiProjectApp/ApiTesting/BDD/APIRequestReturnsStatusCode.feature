Feature: APIRequestReturnsStatusCode

When the user enters an API request, a status code is returned  in the JSON headers

Background:
	Given that I have initialised a DnD 5E API service 
	

@Happy
Scenario: If I make a valid API request, then status code 200 is returned
	When I execute the request with <section>, <subsection>
	Then status code 200 should be returned
	Examples:
	| section  | subsection         |
	| monsters | adult-black-dragon |
	| monsters | flesh-golem        |
	| monsters | ettin              |
	| spells   | ?name=fireball     |
	| spells   | ?name=blight       |
	| spells   | ?name=heat-metal   |
	| classes  | paladin            |
	| classes  | wizard             |
	| classes  | cleric             |


@Sad
Scenario: If I make an invalid API request, then status code should be 404
	When I execute the request with <section>, <subsection>
	Then status code 404 should be returned
	Examples: 
	| section  | subsection    |
	| monsters | JoeMcCann     |
	| monsters | Cormac        |
	| monsters | Lucas         |
	| classes  | test-engineer |
	| classes  | dev-ops       |
	| classes  | developer     |