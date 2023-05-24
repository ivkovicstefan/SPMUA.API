﻿using SPMUA.Model.Commons;
using SPMUA.Model.DTOs.Appointment;
using SPMUA.Model.Models;

namespace SPMUA.Repository.Contracts
{
    public interface IAppointmentRepository
    {
        Task<List<AppointmentDTO>> GetAllAppointmentsAsync();

        Task<AppointmentDTO> GetAppointmentByIdAsync(int appointmentId);

        Task<int> CreateAppointmentAsync(AppointmentDTO appointmentDTO);

        Task<List<TimeInterval>> GetBookedAppointmentIntervalsForAsync(DateTime date);

        Task<List<DateOnly>> GetDatesWithAppointmentsAsync(DateTime fromDate, DateTime toDate);

        Task UpdateAppointmentStatusAsync(int appointmentId, int appointmentStatusId);
    }
}
