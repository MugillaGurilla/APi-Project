Feature: APIRequestReturnsJSONFormat

An API request returns information formatted as JSON

Background:
	Given that I have initialised a DnD 5E API service 

@Happy
Scenario: If I enter a valid API request the information returned should be formatted as JSON
	When I execute the request with <section>, <subsection>
	Then the response should be in a Json format
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
Scenario: If I enter an invalid API request the information returned should be formatted as JSON
	When I execute the request with <section>, <subsection>
	Then the response should be in a Json format
	Examples: 
	| section  | subsection    |
	| monsters | JoeMcCann     |
	| monsters | Cormac        |
	| monsters | Lucas         |
	| spells   | ?name=Slap    |
	| spells   | ?name=Slam    |
	| spells   | ?name=snoosh  |
	| classes  | test-engineer |
	| classes  | dev-ops       |
	| classes  | developer     |
	
