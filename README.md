# Merketo - World's best products!

Built on the ASP.NET Core MVC framework, this application employs Identity for user management and authentication. It effectively stores and manages data using Entity Framework Core with two local SQL database files.

## Features

- User Registration: Users can register an account using the "Sign In" form (NOTE! first registered user gets "admin" role).
- User Login: Users can log in to their account using their credentials (and log out when logged in).
- Product Management: Admins can create, edit, and delete products (only admins can access these features). Admins can see all registered users in 'admin dashboard', and what "role" users have. When products are created (when no products in database there is a message that say there is no products yet), they will be showcased in the "Best Collection" section on the homepage, as well as under the "Products" header link. When you click on the product you will get to a 'product details' view.
- ProductTag Management: You can add tags manually into database, and you can add one or more tags to products manually.
- User Contacts: Users can send a message through the 'contactform', and all users/messages will be stored in the database.
- Success Alerts: When signing up/logging in/logging out/creating products/editing products/deleting products/sending messages successfully, user/admin will get a success message.

## In Progress

The following features are currently in progress:

- Update the code to a more 'dynamic' structure.
- Add 'real' product images to all products, instead of placeholders.
- Allow admins to manage users in the admin dashboard.

## Future Updates

Here are some planned updates for future versions of the project:

- Add a 'search functionality' for all products.
- Add a functionality to the 'newsletter section' with a integrated autoresponder.
- Add social media accounts/links.
- Add a 'cart' view.
- Allowing users to make online payments for their orders (add a payment gateway).
- Add more details in user account, with personal information and order history etc.
- Allowing users to leave reviews and ratings for products.
- Add SEO techniques to enhance organic reach.
- More 'issues' to come...
