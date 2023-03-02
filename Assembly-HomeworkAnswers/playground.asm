.MODEL small
.STACK
.DATA
    msg1    db 13,10,'Enter a string of 3 characters: $'
    msg2    db 13,10,'The chars in reversed order: $'
    firstChar db 0
    middlechar db 0
    lastChar db 0
    crlf db 13, 10, '$'
.CODE
  mov AX, @data
  mov DS, AX
  
  lea DX, msg1
  mov AH, 09h
  int 21h
  
  mov AH, 01h
  int 21h
  mov firstChar, AL ;store the first char
  
  mov AH, 01h
  int 21h
  mov middleChar, AL ;store the second char
  
  mov AH, 01h
  int 21h
  mov lastChar, AL ;store the last char
  
  lea DX, crlf ; newline
  mov AH, 09h
  int 21h
  
  ; print in reversed order
  lea DX, msg2
  mov AH, 09h
  int 21h
  
  mov DL, lastChar
  mov AH, 02h
  int 21h
  
  mov DL, middleChar
  mov AH, 02h
  int 21h
  
  mov DL, firstChar
  mov AH, 02h
  int 21h
END

