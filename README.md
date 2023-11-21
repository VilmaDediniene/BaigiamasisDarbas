# BaigiamasisDarbas

Testuojama svetainė: [PatoguPirkti](https://www.patogupirkti.lt/)

1. Login
	1. Login with valid credentials
		1. Open the page [PatoguPirkti](https://www.patogupirkti.lt/)
		1. Click a button "Decline cookies"
		1. Click “Prisijungti”
		1. Enter username “t0791759@gmail.com”
		1. Enter password “PatoguPirkti569”
		1. Click “Prisijungti”
		1. *Assert* We are logged in, see a button “Atsijungti”

1. Search box
	1. Searching for a book in a search box
		1. The page is opened
		1. Enter “Kakė makė” in search box
		1. Click “Search” button
		1. *Assert* Kakė makė is visible on the page

1. Shopping cart 
	1. Adding a product to shopping cart
		1. The page is opened
		1. Enter “Pasakų knygelių advento kalendorius” in a search box
		1. Click “Search” button
		1. Click the button “Į krepšelį”
		1. *Assert* A book “Pasakų knygelių advento kalendorius” is visible in a shopping cart 
		
1. Wishlist
	1. Adding a product to a wishlist
		1. The page is opened
		1. Enter “Gilus darbas” in a search box
		1. Click on the book "Gilus darbas"
		1. Click the button “Į norų sąrašą”
		1. Close pop up window  “„Gilus darbas“ įtraukta į Jūsų norų sąrašą.”
		1. Click the button “Wishlist” above
		1. *Assert* A book “Gilus darbas” is visible in a wishlist
		
1. Logout
    1. Logging out from the page
    	1. The page is opened
		1. Ckick the button "Atsijungti"
		1. *Assert* Button "Prisijungti" is visible

