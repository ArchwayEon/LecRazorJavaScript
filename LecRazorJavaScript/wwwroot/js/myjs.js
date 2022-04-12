'use strict';
let h1s = document.getElementsByTagName('h1');
h1s[0].style.backgroundColor = "green";

// Numbers
let n1 = 42;
let n2 = 3.345;
let n3 = 1.23e5; // 1.23 * 10^5
let n4 = 0o23;   // octal
let n5 = 0x23;   // hexadecimal
let n6 = 0b101;  // binary
console.log(`${n1} ${n2} ${n3} ${n4} ${n5} ${n6}`); // String interpolation

// Strings
let s1 = "This is a string";
let s2 = 'This is also a string';
let s3 = "This has a 'quote'";
let s4 = 'This also has a "quote"';
console.log(s1);
console.log(s2);
console.log(s3);
console.log(s4);

// Booleans
let b1 = true;
let b2 = false;
console.log(`${b1} ${b2}`);

// Arrays
let a1 = [];
let a2 = [1, "string", true, [2, false, 'string']];
console.log(a1);
console.log(a1.length);
console.log(a2);
console.log(a2.length);
a1[0] = "Some string";
console.log(a1.length);
console.log(a2[2]);
console.log(a2[3][2]);

