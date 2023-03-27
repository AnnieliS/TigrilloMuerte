INCLUDE globals.ink

{talkedtoPriest==false: ->main | ->main2}

===main===
Hey Gordito can I ask some questions? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
That's rude#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
You probably killed many of my friends!#speaker:Rosa #portrait:Rosa #color:1,1,1,1
Fair #speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
So, what do you want mono#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
~talkedtoPriest=true
->qloop


===main2===
So, what do you want mono#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
->qloop
===qloop===
It's rosa for you#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    +[headress]
    ->checkHeadress
    +[beads]
    ->beads
    +[statue]
    ->checkRiddle
    
    ===checkHeadress===
    {hasStatue==true && hasBeads ==true: ->yesheadress | ->noheadress}
    
    ===yesheadress===
    I have them both. Give the headress#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    Ugh. Fine.#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    ~gotHeadress=true
    Now go away#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    ->finish
    
    
    ===noheadress===
    Where can I get a ceremonial headress?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    If you manage to get both the beads and the statue I'll give you mine#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    Anything else mono?#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    +[question]
    ->qloop
    +[nothing]
    ->finish
    ===beads===
    Where can I get ceremonial beads?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    I dropped some in the village's well sometime#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    Probably still there#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    ~canBeads=true
    What more do you want mono? #speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    +[question]
    ->qloop
    +[nothing]
    ->finish
    
    ===checkRiddle===
    {answeredRiddle==true: ->alreadyAnswer | ->checkwater}
    
    ===checkwater===
    {riddle==true: ->riddleq | ->statue}
    
    ===statue===
    How can I get a golden Statue?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    There's a holy well by one of the forest temples#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    Here's a little pot to fill it up with#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    Why just give it to me?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
   What am I supposed to do with it? #speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
   Fair.#speaker:Rosa #portrait:Rosa #color:1,1,1,1
   ~canWater=true
   I asked about a statue thou.#speaker:Rosa #portrait:Rosa #color:1,1,1,1
   ...#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
   Where is it apestar#speaker:Rosa #portrait:Rosa #color:1,1,1,1
  ~riddle = true
  ->riddleq
  ===riddleq===
   There is one in the temple#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
   It's like a maze in there. Where exactly?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    Answer me this riddle and I'll tell you#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    In the sky, I soar,#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    With feathers of gold,#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
I bring life to the land,#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
And make the crops grow bold.#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
What am I?"#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
+[A Eagle]
->wrong
+[The Sun]
->right
+[Tlaloc]
->wrong
    
    
    
    ===right===
    After entering, go up, up, left, right, left.#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    ~canTemple= true
    It should be there#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    Finally#speaker:Rosa #portrait:Rosa #color:1,1,1,1
   What else mono#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
   +[question]
   ->qloop
   +[nothing]
    ->finish
    
    ===wrong===
    estupido mono#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    ->END
    
    ===alreadyAnswer===
    The water is in the forest.#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    Anything else bebé#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1
    +[question]
    ->qloop
    +[go away]
    ->finish
    
    ===finish===
    Chao Gordito#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    Don't come by again#speaker:Gordo #portrait:Priest #color:0.7,0.35,0,1

->END