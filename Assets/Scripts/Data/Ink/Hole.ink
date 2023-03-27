INCLUDE globals.ink

{canDig == false: ->cantDig | ->Dig }

=== cantDig ===
 I should probably leave it alone#speaker:Rosa #portrait:Rosa #color:1,1,1,1
 ->END
 
 ===Dig===
 {dug == true: ->aldu | ->digdig }
 
 ===digdig===
 This is probably where mi hermano was killed!#speaker:Rosa #portrait:Rosa #color:1,1,1,1
 +[dig]
    ->dig2
 ->END
 ===dig2===
~dug=true
->END
=== aldu ===
Pobrecito...#speaker:Rosa #portrait:Rosa #color:1,1,1,1
 ->END