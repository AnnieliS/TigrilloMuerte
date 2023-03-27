INCLUDE globals.ink

-> main

=== main ===

Hola #speaker:Rosa #portrait:Rosa #color:1,1,1,1
Hola compai como estas? #speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
Bien cariño, tienes un minuto?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
->qloop

=== qloop ===
Para ti? Siempre #speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
    +[headress]
        ->headress
    +[knife]
        ->knife
    +[herbs]
        ->herbs
        
=== headress ===
 Do you know something about a ceremonial headress? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
 A what? #speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
    +[more question]
         May I ask something more? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
         ->qloop
    +[nevermind]
        ->finish
    
=== knife ===
 Do you know where I could find a knife? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
  Oye chiflada, no me lo recuerdes!#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
   Bad experience?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
    You see this scar over my chest? #speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
     This gordito priest stabbed me and left me in the woods!#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
      knife still there, and just left. Threw some cloth over me, put me in a hole near a small shrine and left.#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
       Will never forgive that gueva#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
        You think it's still there?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
         Probablemente. Don't see a reason why not.#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
         ~canDig = true
            +[more questions]
                 Thank you for telling me 'mano. Can I ask about something else?#speaker:Rosa #portrait:Rosa #color:1,1,1,1
                 ->qloop
            +[stop asking]
                 Sorry bringing up painful subjects#speaker:Rosa #portrait:Rosa #color:1,1,1,1
                 ->finish
=== herbs ===
    Oye cabron you know anything about ceremonial herbs? #speaker:Rosa #portrait:Rosa #color:1,1,1,1
    Oye zorra do I look like a herbívoro to you?#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
     Try asking a mouse or something#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
     +[ask more]
         Well tell me something else then #speaker:Rosa #portrait:Rosa #color:1,1,1,1
         ->qloop
    +[end convo]
        ->finish
     
->finish
=== finish ===
 I'll see you around chulo#speaker:Rosa #portrait:Rosa #color:1,1,1,1
  Adios amiga!#speaker:Xolo #portrait:Xolo #color:0.7,0.35,0,1
-> END