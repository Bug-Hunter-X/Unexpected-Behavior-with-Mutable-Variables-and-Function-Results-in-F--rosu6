let x = ref 10
let y = ref 20

let add x y = !x + !y

let z = add x y

printf "%d\n" z

!x <- 15
!y <- 25

printf "%d\n" (add x y)

//Now z's value won't change, but calling add x y will return the updated sum.