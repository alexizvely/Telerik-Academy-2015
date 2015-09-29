Memory  = "0";      // initialise memory variable
Current = "0";      // and value of Display ("current" value)
Operation = '';      // Records code for eg * / etc.
MAXLENGTH = 30;     // maximum number of digits before decimal!
Sign = 'P';

function Equal() {
    
}

function addDigit (x) {
	if (Current.length > MAXLENGTH){ 
 		Current = "Too long"; //limit length
 			} else{
 				if ((eval(Current) = "0") && (Current.indexOf(".") = -1)){
 					Current = x;
            		} else{
            			Current = Current + x;
					      }
				}}
   document.Calculator.Display.value = Current;
}

function Plus () {
	Operation='+';
}

function Minus () {
var Display = document.getElementById("Display").value;
if (x === '') {
Sign = 'N'; 
} else { 
	Operation = 'M'; 
}
}

function Divide () {
	Operation='D';
}

function Multiply () {
	Operation='X';
}

