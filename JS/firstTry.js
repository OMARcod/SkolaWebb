var drawWinston = function(faceX, faceY) {
    fill(255, 255, 0);
    ellipse(faceX, faceY, 180, 180); // face
    fill(46, 46, 41);
    ellipse(faceX - 30, faceY - 50, 30, 30); // eyes
    ellipse(faceX + 44, faceY - 55, 30, 30);
    fill(252, 65, 65);
    ellipse(faceX + 19, faceY + 32, 82, 81); // mouth
};

var totaldonat;

var CalcDonat = function (yars) {

   totaldonat = 4 * 12 * yars;
   return totaldonat;
};


var multiply = function(num1, num2) {
   return  7 * totaldonat;};

fill(255, 0, 0);
text("2-year-old Winston:", 10, 20);
text(CalcDonat(2) , 10 , 40 );
text(multiply(2,CalcDonat),10 ,50);

text("14-year-old Winston:", 200, 20);
text(CalcDonat(14) , 200 , 40 );
text(multiply(2,CalcDonat),200 ,50);

text("25-year-old Winston:", 10, 220);
text(CalcDonat(25) , 10 , 240 );
text(multiply(2,CalcDonat),10 ,250);

text("65-year-old Winston:", 200, 220);
text(CalcDonat(65) , 200 , 240 );
text(multiply(2,CalcDonat),200 ,250);

drawWinston(99, 117);
drawWinston(294, 117);
drawWinston(101, 316);
drawWinston(294, 316);



//i whant to get how much it cost in year if evrey donat cost 10 kr 
