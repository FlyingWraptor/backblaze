﻿using System;
using System.Threading;
using System.Threading.Tasks;

using Bytewizer.Backblaze.Models;

namespace Bytewizer.Backblaze.Agent
{
    public interface IBackblazeFilesAgent
    {
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string fileId, string localFilePath, IProgress<ICopyProgress> progress);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string fileId, string localFilePath, IProgress<ICopyProgress> progress, CancellationToken cancel);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string bucketName, string fileName, string localFilePath, IProgress<ICopyProgress> progress);
        Task<IApiResults<DownloadFileResponse>> DownloadAsync(string bucketName, string fileName, string localFilePath, IProgress<ICopyProgress> progress, CancellationToken cancel);
        Task<IApiResults<UploadFileResponse>> UploadAsync(string bucketId, string fileName, string localFilePath, IProgress<ICopyProgress> progress);
        Task<IApiResults<UploadFileResponse>> UploadAsync(string bucketId, string fileName, string localFilePath, IProgress<ICopyProgress> progress, CancellationToken cancel);
        Task<IApiResults<ListFileNamesResponse>> GetNamesAsync(string bucketId, string prefix, string delimiter, string startFileName, long maxFileCount);
        Task<IApiResults<ListFileVersionResponse>> GetVersionsAsync(string bucketId, string prefix, string delimiter, string startFileName, long maxFileCount);
        Task<IApiResults<GetFileInfoResponse>> GetInfoAsync(string fileId);
        Task<IApiResults<HideFileResponse>> HideAsync(string bucketId, string fileName);
        Task<IApiResults<DeleteFileVersionResponse>> DeleteAsync(string fileId, string fileName);
        Task<IApiResults<DeleteFileVersionResponse>> DeleteAllAsync(string bucketId);
    }
}