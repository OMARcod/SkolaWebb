let cpuScore = 0;
let userScore = 0;
let cpuChoice = "";
let choices = ['rock', 'paper', 'scissors']; 

let rockBtn = document.getElementById('rock');
let paperBtn = document.getElementById('paper');
let scissorsBtn = document.getElementById('scissors'); 


let youScore = document.getElementById("ScoreYOU");
let CPUScore = document.getElementById("ScoreCPU");
let winsLose = document.getElementById("winsLose");


rockBtn.addEventListener('click',function() { game('rock'); });
paperBtn.addEventListener('click',function() { game('paper'); });
scissorsBtn.addEventListener('click',function() { game('scissors'); }); 

function game(type){
cpuChoice = choices[Math.floor(Math.random() * choices.length)];
    
    
    
if (type == 'rock') { 
console.log('You chose: ROCK');
if (cpuChoice == 'rock')
{ 
winsLose.innerHTML ='CPU chose: ROCK';
winsLose.innerHTML ='It is a draw. No points given.';
}
else if (cpuChoice == 'paper')
{ 
winsLose.innerHTML ='CPU chose: PAPER';
winsLose.innerHTML ='CPU wins.'; cpuScore++; 
}
else 
{ 
winsLose.innerHTML ='CPU chose: SCISSORS';
console.log('You win!'); userScore++; }
}
        
else if(type == 'paper')
    
{ console.log('You chose: Paper');
if (cpuChoice == 'rock')
{ 
console.log('CPU chose: ROCK');
console.log('You win!'); userScore++;
}
else if (cpuChoice == 'paper')
{ 
console.log('CPU chose: PAPER');
console.log('It is a draw. No points given.');
}
else 
{ 
console.log('CPU chose: SCISSORS');
console.log('CPU wins.'); cpuScore++;  }
}

 else if(type == 'scissors')
    
{ console.log('You chose: Paper');
if (cpuChoice == 'rock')
{ 
console.log('CPU chose: ROCK');
console.log('CPU wins.'); cpuScore++; 
}
else if (cpuChoice == 'paper')
{ 
console.log('CPU chose: PAPER');
console.log('You win!'); userScore++;
}
else 
{ 
console.log('CPU chose: SCISSORS');
console.log('It is a draw. No points given.');  }
}
    youScore.innerHTML = "yor score: " +userScore;
    CPUScore.innerHTML = "cpu score: "+ cpuScore;
}



   
