import raylibpy as rl

rl.init_window(800, 450, "My Raylib Project")
rl.set_target_fps(60)

while not rl.window_should_close():
    rl.begin_drawing()
    rl.clear_background(rl.RAYWHITE)
    rl.draw_text("Raylib is ready!", 300, 200, 20, rl.DARKBLUE)
    rl.end_drawing()

rl.close_window()
