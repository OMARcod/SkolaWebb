var drawWinston = function(faceX, faceY) {
    fill(255, 255, 0);
    ellipse(faceX, faceY, 180, 180); // face
    fill(46, 46, 41);
    ellipse(faceX - 30, faceY - 50, 30, 30); // eyes
    ellipse(faceX + 44, faceY - 55, 30, 30);
    fill(252, 65, 65);
    ellipse(faceX + 19, faceY + 32, 82, 81); // mouth
};


 var total = 0;
var numofdounat = function(year) {

  total = 3*365*year ;
  return total;
} ;

var dounatpris = function() {

return 10*total;
};

fill(255, 0, 0);

text("2-year-old Winston:", 10, 20);
text(numofdounat(2), 10, 40);
text(dounatpris(),10,50);

text("14-year-old Winston:", 200, 20);
text(numofdounat(14), 200, 40);
text(dounatpris(),200,50);

text("25-year-old Winston:", 10, 220);
text(numofdounat(25), 10, 240);
text(dounatpris(),10,250);

text("65-year-old Winston:", 200, 220);
text(numofdounat(65), 200, 240);
text(dounatpris(),200,250);

drawWinston(99, 117);
drawWinston(294, 117);
drawWinston(101, 316);
drawWinston(294, 316);