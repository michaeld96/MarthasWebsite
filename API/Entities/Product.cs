namespace API.Entities;
/// <summary>
/// Each Product will be a art piece.
/// </summary>
public class Product
{
    public int Id { get; set; }
    /// <summary>
    /// Name of the art piece.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// A Description of the art piece.
    /// </summary>
    public required string Description { get; set; }
    /// <summary>
    /// Price of the art piece.
    /// </summary>
    public long Price { get; set; }
    /// <summary>
    /// The art piece's URL.
    /// </summary>
    public required string PictureUrl { get; set; }
    /// <summary>
    /// Type of the piece. Examples: Oil, Acrylic, etc. 
    /// </summary>
    public required string Type { get; set; }
}
