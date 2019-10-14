Feature: FeatureFlag
 Toggling new feature


Scenario: Add new feature
	Given Got to feature flag management page
	And Enter new fetaure Name
	And select status
	When I press add
	Then New feature should be added on list
