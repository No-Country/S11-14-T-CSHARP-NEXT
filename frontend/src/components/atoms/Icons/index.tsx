import {
  FaChessBoard,
  FaTable,
  FaUser,
  FaChartSimple,
  FaBed,
  FaBan,
  FaGear,
  FaCircleQuestion,
  FaMessage,
  FaRightFromBracket,
} from 'react-icons/fa6';
import { TfiBookmarkAlt } from 'react-icons/tfi';
import { BsQuestionCircle } from 'react-icons/bs';
import {
  AiOutlineCheckCircle,
  AiOutlineCheckSquare,
  AiOutlinePlus,
  AiOutlineSearch,
} from 'react-icons/ai';
import { BiSolidMessageAltDetail } from 'react-icons/bi';
import { MdEdit, MdKeyboardArrowRight } from 'react-icons/md';

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

export const ReservationInfoIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <TfiBookmarkAlt size={size} className={className} />;
};

export const IncidentsIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <BsQuestionCircle size={size} className={className} />;
};

export const RoomsAvailableIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <AiOutlineCheckCircle size={size} className={className} />;
};

export const RoomsOcupiedIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <FaBan size={size} className={className} />;
};

export const PendingCheckInIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <AiOutlineCheckSquare size={size} className={className} />;
};

export const SearchIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <AiOutlineSearch size={size} className={className} />;
};

export const PlusIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <AiOutlinePlus size={size} className={className} />;
};

export const EditIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <MdEdit size={size} className={className} />;
};

export const ArrowRight: React.FC<IconsProps> = ({ size, className }) => {
  return <MdKeyboardArrowRight size={size} className={className} />;
};

export const NewMessagesIcon: React.FC<IconsProps> = ({ size, className }) => {
  return <BiSolidMessageAltDetail size={size} className={className} />;
};
