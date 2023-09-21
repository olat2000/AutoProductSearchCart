Feature: Products

As a user on Automation website
I want search for products
So that I would be able to verify cart

@tag1
Scenario: Search for Products  
	Given I navigate to automation website
    When I click on Login 
      And Input my details
      And I click on Login button
    When I click on product menu
       Then I am on the products page
       And I enter product name in search bar 
    When I click search button
    Then related products are visible
       And I click on view product
       And I add the product to the cart
       And I click on view cart
    Then product should be visibled
     
 