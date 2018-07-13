# MorseCodeDecoder
Decodifica Codice Morse

L'applicazione è stata sviluppata con Visula Studio 2017 - Framework 4.7

Un po' di storia:

l codice Morse è un sistema per trasmettere lettere, segni di punteggiatura e numeri per mezzo di codici a intermittenza . Questo alfabeto venne inventato nel 1835 dall'americano Samuel Morse (da cui prende il nome) e venne perfezionato da uno dei suoi collaboratori : Alfred Vail.

Il codice Morse è stato il primo sistema moderno di trasmissione a distanza di messaggi. Ed  è anche un ottimo sistema per mandare bigliettini segreti , che ormai nessuno, anche se li dovesse intercettare, sarebbe in grado di leggere. 
Ecco lo schema delle lettere e dei numeri del codice Morse:

        ".-" -> "a"
        "-..." -> "b"
        "-.-." -> "c"
        "-.." -> "d"
        "." -> "e"
        "..-." -> "f"
        "--." -> "g"
        "...." -> "h"
        ".." -> "i"
        ".---" -> "j"
        "-.-" -> "k"
        ".-.." -> "l"
        "--" -> "m"
        "-." -> "n"
        "---" -> "o"
        ".--." -> "p"
        "--.-" -> "q"
        ".-." -> "r"
        "..." -> "s"
        "-" -> "t"
        "..-" -> "u"
        "...-" -> "v"
        ".--" -> "x"
        "-.--" -> "y"
        "--.." -> "z"
        "-----" -> "0"
        ".----" -> "1"
        "..---" -> "2"
        "...--" -> "3"
        "....-" -> "4"
        "....." -> "5"
        "-...." -> "6"
        "--..." -> "7"
        "---.." -> "8"
        "----." -> "9"

Il codice Morse si basa su cinque semplici stadi : il punto, la linea, l'intervallo breve, l'intervallo medio e l'intervallo lungo. Ogni punto e ogni linea, disposti in una precisa sequenza , rappresentano una lettera o un numero , mentre gli intervalli rappresentano le pause , da quella breve (tra lettera e lettera), a quella media (tra una parola e l'altra), a quella più lunga (pausa tra le frasi).

Il messaggio Morse viene trasmesso inviando un  impulso elettrico  lungo un filo che collegava le stazioni trasmittente e ricevente, ossia  mediante l'uso del telegrafo (inventato dallo stesso Morse). Agli inizi del XX secolo , al telegrafo a filo di Morse venne affiancato quello senza fili grazie all'invenzione di Guglielmo Marconi: la radio .


## Questa applicazione console prende in ingresso il codice morse inserito e restituisce una stringa decodificata leggibile.

Esempio (3 spazi per le parole e 1 spazio per il singolo carattere):

    D: \> DecodeMorse  ".... . -.--   .--- ..- -.. ."

    Your Morse code decode is: HEY JUDE
