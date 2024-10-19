using Godot;
using System;

public partial class tile_map : TileMap
{
	// Called when the node enters the scene tree for the first time.
	int layers = 0;
	public override void _Ready()
	{
		layers = GetLayersCount();
		for(int i = 0; i < layers; i++)
		{
			if(GetLayerName(i).EndsWith(".5"))(i, cell
			{
				 // Получаем все используемые клетки в слое
                var usedCells = GetUsedCells(i);
                foreach (var cell in usedCells)
                {
                    // Получаем текущий тайл
                    int tileId = GetCellTileData();
                    if (tileId != -1) // Проверяем, что тайл существует
                    {
                        // Удаляем текущий тайл
                        SetCell(i, cell, -1);
                        // Устанавливаем тайл на новую позицию
                        SetCell(i, new Vector2(cell.x, cell.y + OffsetY), tileId);
                    }
                }
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
