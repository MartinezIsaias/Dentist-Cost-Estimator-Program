# Program Explanation
<b>Purpose: This assignment explores the use of variables and simple arithmetic.</b><br>
<br>
Create an interactive Windows Console application (Chapter 2) or Windows Forms application (Chapter 3) designed for estimating costs for a local dentist office. The following steps outline the process:
You have been hired by Bigg Smiles Dental to create a price quote calculator. The program will prompt users to enter information about their dental care needs and will output a quote for the total cost of care. The following information will need to be collected:
+ Name of client (String)
+ Type of procedure (cleaning, filling, crown, etc.) (String)
+ Duration of Procedure (hours) (Double)
+ Amount of material needed (Ounces) (double)
+ Number of additional staff needed (int)
+ Senior Citizen?  (0 or 1) (int)
  
All dental work requires a consultation fee of $100. Dr. Biggs charges $50 per hour during procedures. All other staff charge $25 per hour during procedures. Dental material costs 10 cents per ounce. All senior citizen patients receive a 10% discount. The total cost without the discount is calculated by the Formula: <br>
<b>Total Cost = consultation fee + (duration * dentist fee per hour) + (duration * staff number* staff fee per hour) + (material ounce* material cost per ounce)</b><br>
<b>To apply the discount:   With discount = total cost – (total cost * .10)</b>
