Feature: sanity check

  Scenario: ping
    When I 'GET' the api '/ping'
    Then the server response will match 
    """
    pong
    """

  Scenario: show sample items
    When I 'GET' the api '/items'
    Then the server response will match
    """
    [
      { barcode: "82202001", name: "juice", unit: "", price: 5.0 },
      { barcode: "82202002", name: "biscuit", unit: "", price: 13.0 },
      { barcode: "82202003", name: "cola", unit: "250ml", price: 4.2 }
    ]
    """

  Scenario: show sample error
    When I 'GET' the api '/dontcall'
    Then the server error response will match
    """
    It is a sample error
    """