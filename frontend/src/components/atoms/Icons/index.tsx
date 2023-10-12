import {
  FaChessBoard,
  FaTable,
  FaUser,
  FaChartSimple,
  FaBed,
  FaGear,
  FaCircleQuestion,
  FaMessage,
  FaRightFromBracket,
} from 'react-icons/fa6';

interface IconsProps {
  size?: string;
  className?: string;
}

export const DashboardIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaChessBoard size={size} className={className} />;
};

export const ReservationsIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaTable size={size} className={className} />;
};

export const StaffIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaUser size={size} className={className} />;
};

export const StatisticsIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaChartSimple size={size} className={className} />;
};

export const RoomsIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaBed size={size} className={className} />;
};

export const SettingsIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaGear size={size} className={className} />;
};

export const IncidentIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaCircleQuestion size={size} className={className} />;
};

export const MessageIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaMessage size={size} className={className} />;
};

export const ExitIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaRightFromBracket size={size} className={className} />;
};
