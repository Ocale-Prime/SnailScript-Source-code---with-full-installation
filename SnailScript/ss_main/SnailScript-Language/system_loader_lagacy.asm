; Created By Ocale (C)

.load
.done 


.start:
    mov rax, 2
    cmp dx, 3
    cmp r1, 3
    .load:
      mov edx, 2
      mov eax, 2
    D001: db 0x300000f$-equ
  .done:
    mov rdx, 0

