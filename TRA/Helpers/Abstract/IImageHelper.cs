using TRA.Entities.ComplexTypes;
using TRA.Entities.Dtos;
using TRA.Shared.Utilities.Results.Abstract;

namespace TRA.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
