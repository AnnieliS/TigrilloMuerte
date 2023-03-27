INCLUDE globals.ink

{talkedtotablet==false: -> main | ->main2}

=== main ===

I hope I Still remember how to read this #speaker:Rosa #portrait:Rosa #color:1,1,1,1
To open the gate, complete my ritual #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.33,1
    +[Which?]
        -> which
    +[OK]
        -> finish



=== which===
Are you seriously speaking to a stone tablet? #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.33,1
Are you going to tell me what the ritual is? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
... #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.3,1
    +[go on]
        ->goOn
    +[leave]
        ->finish

=== goOn ===
Bring me my statue, sacred water, beads, a headress and a knife for the ceremony #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.3,1
Also the ritual needs to be preformed on a tainted cloth #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.3,1
Once you've met all my requirements, we'll meet at the stone table #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.3,1
Where do I get these? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
~talkedtotablet = true
Sis, again. I'm a stone tablet. #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.3,1
    +[right]
        ->finish
    +[rude]
        ->finishRude

=== finishRude ===
Stones are dumb #speaker:Rosa #portrait:Rosa #color:1,1,1,1

-> END

=== finish ===
I should probably go now #speaker:Rosa #portrait:Rosa #color:1,1,1,1
->END

===main2===
You haven't gotten all the items yet #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.33,1
What do I need again? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
A knife, Cloth, Water, Beads, Headress, Herbs and a Statue #speaker:Tablet #portrait:Sign #color:0.83,0.81,0.33,1
On it. #speaker:Rosa #portrait:Rosa #color:1,1,1,1    

-> END