.MODEL small
.STACK
.DATA
    msg1 db 'hello, world', 0
.CODE
  mov AX, @data
  mov DS, AX
  
  lea DX, msg1
  mov AH, 09H
  int 21h
END

