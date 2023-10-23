import React from 'react';

interface StatusTag {
  status: string;
}
const StatusTag: React.FC<StatusTag> = ({ status }) => {
  function setColor(status: string): string {
    switch (status) {
      case 'Libre':
        return 'bg-green-500';
      case 'Reservada':
        return 'bg-red-400';
      case 'Mantenimiento':
        return 'bg-yellow-400';
      default:
        return 'bg-neutral-400';
    }
  }

  return (
    <div className={`text-white text-xs font-medium px-4 py-2 rounded ${setColor(status)}`}>
      {status}
    </div>
  );
};

export default StatusTag;
