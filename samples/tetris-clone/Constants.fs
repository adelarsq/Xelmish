﻿module Constants

open Xelmish.Model

let gridWidth = 10
let gridHeight = 20
let padding = 30
let tiledim = 20
let resWidth = padding + (tiledim * gridWidth) + padding + (tiledim * 6) + padding
let resHeight = padding + (tiledim * gridHeight) + padding

type Shape = {
    rotations: ((int * int) list) []
    colour: Colour
}

let shapes = [
    {   rotations = [|  [0,0; 1,0; 0,1; 1,1] |] // O
        colour = Colours.cyan }
    {   rotations = [|  [0,0; 1,0; 2,0; 3,0]    // I
                        [2,0; 2,1; 2,2; 2,3] |]
        colour = Colours.red }
    {   rotations = [|  [0,0; 1,0; 1,1; 2,1]    // Z
                        [2,0; 2,1; 1,1; 1,2] |] 
        colour = Colours.green }
    {   rotations = [|  [1,0; 2,0; 1,1; 0,1]    // S
                        [1,0; 1,1; 2,1; 2,2] |] 
        colour = Colours.blue }
    {   rotations = [|  [0,0; 1,0; 2,0; 0,1]    // L
                        [0,0; 1,0; 1,1; 1,2]
                        [0,1; 1,1; 2,1; 2,0]
                        [1,0; 1,1; 1,2; 2,2] |] 
        colour = Colours.orange }
    {   rotations = [|  [0,0; 1,0; 2,0; 2,1]    // J
                        [1,0; 1,1; 1,2; 0,2]
                        [0,0; 0,1; 1,1; 2,1]
                        [1,0; 2,0; 1,1; 1,2] |] 
        colour = Colours.magenta }
    {   rotations = [|  [0,0; 1,0; 2,0; 1,1]    // T
                        [1,0; 1,1; 1,2; 0,1]
                        [0,1; 1,1; 2,1; 1,0]
                        [1,0; 1,1; 1,2; 2,1] |]
        colour = Colours.silver }
]