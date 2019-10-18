### Title: cssbs-hw16
#### Author: Greg Stephens
#### Date: 19 Aug, 2019
___

###### Read chapter 16, pages 363 – 379 in the C# Step by Step book.

##### 1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
pg365
- The NOT (~) operator `int a = ~204` 0b0_11111111_11111111_11111111_00110011
- The left-shift (<<) operator `int b = 204 << 2` 0b0_00110000, or 48 decimal. There is a corresponding right-shift operator (>>)
- The OR (|) operator `int c = 204 | 24` 204 | 24 has the value 220 (204 is 0b0_11001100, 24 is 0b0_00011000, and 220 is 0b0_11011100
- The AND (&) operator `int d = 204 & 24` 204 is 0b0_11001100, 24 is 0b0_00011000, and 8 is 0b0_00001000
- The XOR (^) operator `int e = 204 ^ 24` 212 (0b0_11001100 ^ 0b0_00011000 is 0b0_11010100

https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm

##### 2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.
yes: `int b = 204 >> 2`

##### 3. Explain in detail this code: bits & (1 << index(4));.
the expression verifies whether bit specified in the parentheses(bit 5) is true or false(1/0)

##### 4. Explain in detail this code: bits |= (1 << index);.
this expression sets the value to the specified left shifted index(bit 5)

##### 5. Explain in detail this code: bits &= (1 << index);.
this expression assigns the value from the specified left shifted index

##### 6. How does C# interpret this? bool peek = bits[n];


##### 7. How does C# interpret this? bits[n] = true;


##### 8. How does C# interpret this? bits[n] ^= true;


##### 9. Assume that users were assigned read, write, and execute permissions according to this scheme:
`read = 1, write = 2, execute = 4`. **How would you interpret the following user permissions:**

    (a) permission = 0 //none
    (b) permission = 1 //read
    (c) permission = 2 //write
    (d) permission = 3 //read & write
    (e) permission = 4 //execute
    (f) permission = 5 //read & execute
    (g) permission = 6 //write & execute
    (h) permission = 7 //read & write & execute



##### 10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?

    (a) permission = 0 //none 000
    (b) permission = 1 //read 001
    (c) permission = 2 //write 010
    (d) permission = 3 //read & write 011
    (e) permission = 4 //execute 100
    (f) permission = 5 //read & execute 101
    (g) permission = 6 //write & execute 110
    (h) permission = 7 //read & write & execute 111
